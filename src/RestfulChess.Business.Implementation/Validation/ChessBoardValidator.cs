using FluentValidation;
using RestfulChess.Common.Contracts.Games;

namespace RestfulChess.Business.Implementation.Validation
{
    public class ChessBoardValidator : AbstractValidator<ChessBoard>
    {
        public ChessBoardValidator()
        {
            RuleForEach(x => x.Fields).SetValidator(new BoardFieldValidator());
            RuleFor(x => x).Must(x => x.Fields.Count == 64).WithMessage("A chess board must have exactly 64 fields");
        }
    }
}
