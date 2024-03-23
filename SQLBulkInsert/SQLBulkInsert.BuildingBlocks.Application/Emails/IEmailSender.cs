
namespace SQLBulkInsert.BuildingBlocks.Application.Emails
{
    public interface IEmailSender
    {
        Task SendEmail(EmailMessage message);
    }
}
