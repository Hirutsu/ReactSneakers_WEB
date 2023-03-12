// отправитель - устанавливаем адрес и отображаемое в письме имя
using System.Net;
using System.Net.Mail;

MailAddress from = new MailAddress("official_hirutsu@mail.ru", "React-Sneakers");
// кому отправляем
MailAddress to = new MailAddress("ya.n.2@mail.ru");
// создаем объект сообщения
MailMessage m = new MailMessage(from, to);
// тема письма
m.Subject = "Ты заскамлен уебан, если в течение суток не придут деньги на +89873246874 QIWI. Жди повесточку в военкомат";
// текст письма
m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
// письмо представляет код html
m.IsBodyHtml = true;
// адрес smtp-сервера и порт, с которого будем отправлять письмо
SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
// логин и пароль
smtp.Credentials = new NetworkCredential("official_hirutsu@mail.ru", "0xWLK0gehrNCzHUeZfJS");
smtp.EnableSsl = true;
smtp.Send(m);
Console.WriteLine("Письмо отправлено");