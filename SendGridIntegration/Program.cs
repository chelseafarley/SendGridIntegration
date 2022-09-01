using SendGrid;
using SendGrid.Helpers.Mail;

static async Task Execute()
{
    var apiKey = "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";
    var client = new SendGridClient(apiKey);
    var from = new EmailAddress("chelsea@tripwiretech.com", "Chelsea");
    var subject = "My Subject - Hi YouTube!";
    var to = new EmailAddress("hello@tripwiretech.com", "Hello");
    var plainTextContent = "How cool an email!";
    var htmlContent = "<strong>How cool an email!</strong>";
    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
    var response = await client.SendEmailAsync(msg);
}

await Execute();