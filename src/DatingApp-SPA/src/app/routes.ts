import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MessagesComponent } from './messages/messages.component';
import { ListsComponent } from './lists/lists.component';
import { AuthGuard } from './_guards/auth.guard';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { MemberDetailResolver } from './_resolvers/member-detail.resolver';

export const appRoutes: Routes = [
    // These routes will get taken as soon as one of the paths get matched. It works from first
    // declared down to last (where '**' is a wildcard trying to catch all).
    { path: '', component: HomeComponent},
    // Example of explicit Guard being used for a route.
    // { path: 'members', component: MemberListComponent, canActivate: [AuthGuard]},
    {
        path: '', // This will match with localhost:4200/members, where it's really localhost:4200/''members
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'members', component: MemberListComponent},
            { path: 'members/:id', component: MemberDetailComponent, resolve: {user: MemberDetailResolver}},
            { path: 'messages', component: MessagesComponent},
            { path: 'lists', component: ListsComponent},
        ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full'} // Handling all non-matched requests to go to 'home'
];
