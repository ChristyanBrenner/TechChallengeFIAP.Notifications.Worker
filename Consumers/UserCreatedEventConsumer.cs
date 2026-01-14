using CloudGames.Contracts.Events;
using MassTransit;

namespace Consumers
{
    public class UserCreatedEventConsumer : IConsumer<UserCreatedEvent>
    {
        public Task Consume(ConsumeContext<UserCreatedEvent> context)
        {
            var message = context.Message;

            Console.WriteLine(
                $"[EMAIL] Bem-vindo! Email enviado para {message.Email} (UserId: {message.UserId})"
            );

            return Task.CompletedTask;
        }
    }
}
