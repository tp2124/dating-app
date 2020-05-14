using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Dtos
{
    // This is very close to the PhotosForDetailedDto. However, this has the PublicId. A case could be made to just re-use the other one as well.
    public class PhotoForReturnDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
    }
}