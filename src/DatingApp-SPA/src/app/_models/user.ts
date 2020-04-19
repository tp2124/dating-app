import { Photo } from './photo';

// The user we are getting returned back. Including all the data from DetailedUser requests.
export interface User {
    id: number;
    username: string;
    knownAs: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    city: string;
    country: string;
    interests?: string; // Only avialable in detailed requests for this and fields below.
    introduction?: string;
    lookingFor?: string;
    photos?: Photo[];
}
