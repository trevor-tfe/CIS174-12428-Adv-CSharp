namespace CIS174TrevorStewart.Models
{
    public interface ITicket
    {
        string Description { get; set; }
        int PointValue { get; set; }
        int SprintNumber { get; set; }
        string Status { get; set; }
        int TicketID { get; set; }
        string TicketName { get; set; }
        List<string> ValidStatus { get; }
    }
}