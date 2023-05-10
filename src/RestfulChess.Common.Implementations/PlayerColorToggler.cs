using RestfulChess.Common.Contracts.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Common.Implementations
{
    /// <summary>
    /// Provides a toggler for <see cref="EPlayerColors"/> between the colors black&white
    /// </summary>
    public class PlayerColorToggler
    {
        public static EPlayerColors ToggleColor(EPlayerColors color)
        {
            switch (color)
            {
                case EPlayerColors.White: return EPlayerColors.Black;
                case EPlayerColors.Black: return EPlayerColors.White;
                case EPlayerColors.None: throw new InvalidOperationException("Cannot toggle color of value none");
                default: throw new NotImplementedException($"Toggle color is not implemented for value {color}");
            }

        }
    }
}
