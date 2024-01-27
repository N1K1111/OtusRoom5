using RabbitMQ.Client;
using System.Text.Json;
using System.Text;
using Notification.Microservice.Core.Settings;
using Notification.Microservice.Core.Interfaces;
using System.Threading.Channels;

namespace Notification.Microservice.Core.Services
{
    public class Producer : IProdecer
    {

        public void Produce(string messageContent)
        {
            Channel ch = new Channel();

            var message = new MessageDto()
            {
                Content = $"{messageContent}"
            };

            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));


            ch._channel.BasicPublish(ch._exchangeName,
                ch._routingKey,
                basicProperties: null,
                body: body);

            ch._channel.Close();
            ch._connection.Close();

        }

    }
}
