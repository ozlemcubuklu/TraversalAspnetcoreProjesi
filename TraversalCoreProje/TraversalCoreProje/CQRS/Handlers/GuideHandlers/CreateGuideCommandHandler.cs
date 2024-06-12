using Data.Concrete;
using Entity;
using MediatR;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using TraversalCoreProje.CQRS.Commands.GuideCommands;

namespace TraversalCoreProje.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
           await _context.Guides.AddAsync(new Guide() {Name=request.Name,Description=request.Description });
           await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
