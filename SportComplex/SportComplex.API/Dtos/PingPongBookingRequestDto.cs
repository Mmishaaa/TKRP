using SportComplex.BLL.Models;

namespace SportComplex.API.Dtos
{
    public class PingPongBookingRequestDto
    {
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public Guid PingPongTableId { get; set; }
        public Guid? CoachId { get; set; }
        public Guid? PingPongEquipmentId { get; set; }
    }
}
