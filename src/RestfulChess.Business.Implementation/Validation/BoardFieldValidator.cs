using FluentValidation;
using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Games;
using RestfulChess.Common.Implementations.Extensions;

namespace RestfulChess.Business.Implementation.Validation
{
    public class BoardFieldValidator : AbstractValidator<BoardField>
    {
        public BoardFieldValidator()
        {
            RuleFor(x => x.FieldColor)
                .NotEqual(Common.Contracts.Enumerations.EPlayerColors.None)
                .WithMessage("A field must have a color of black or white");

            RuleFor(x => x.FigureOnField).NotNull().When(x => x.HasFigureOnField).WithMessage("Figure cannot be null if a figure is on the field");
            RuleFor(x => x.FigureOnField).Null().When(x => x.HasFigureOnField == false).WithMessage("Figure cannot be set if no figure should be on that field");
            RuleFor(x => x.Position.Column).Must(column =>
            {
                var value = (int)column;
                return value >= 1 && value <= 8;
            })
                .WithMessage($"Column must be between {EColumnPosition.A} and {EColumnPosition.H}");
            RuleFor(x => x.Position.Row).Must(row =>
            {
                var value = (int)row;
                return value >= 1 && value <= 8;
            })
                 .WithMessage($"Row must be between {ERowPosition.One} and {ERowPosition.Eight}"); ;

            /*
             Check color per field using:
            		| COL ODD 	|COL EVEN   |
            ROW EVEN|	white	|black	    |
            ROW ODD	|	black	|white	    |
             */
            RuleFor(x => x)
                .Must(field => (AreBothEven((int)field.Position.Column,(int)field.Position.Row) 
                || (AreBothOdd((int)field.Position.Column,(int)field.Position.Row))))
                .When(x => x.FieldColor == EPlayerColors.Black)  
                .WithMessage("The color should be black when both column and row are either odd or even.");

            RuleFor(x => x)
                .Must(field => AreOdEvenMixed((int)field.Position.Column,(int)field.Position.Row))
                .When(x => x.FieldColor == EPlayerColors.White)
                .WithMessage("The color should be white when one of the column or row is odd and the other is even.");
        }

        private bool AreBothOdd(int a, int b)
        {
            if (a.IsOdd() && b.IsOdd()) return true;
            return false;
        }

        private bool AreBothEven(int a, int b)
        {
            if (a.IsEven() && b.IsEven())  return true;
            return false;
        }

        private bool AreOdEvenMixed(int a, int b)
        {
            return (a.IsEven() && b.IsOdd()) || (a.IsOdd() && b.IsEven());
        }
    }
}
