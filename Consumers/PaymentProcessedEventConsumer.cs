using CloudGames.Contracts.Events;
using MassTransit;

namespace Consumers
{
    public class PaymentProcessedEventConsumer : IConsumer<PaymentProcessedEvent>
    {
        public Task Consume(ConsumeContext<PaymentProcessedEvent> context)
        {
            var message = context.Message;

            if (message.Status == PaymentStatus.Approved)
            {
                Console.WriteLine("PAGAMENTO APROVADO!");
                Console.WriteLine($"Agradecemos a sua compra do jogo {message.GameName}");
            }
            else
            {
                Console.WriteLine("PAGAMENTO REJEITADO!");
                Console.WriteLine($"Não foi possivel comprar o jogo {message.GameName}");
            }

            return Task.CompletedTask;
        }
    }
}
