using AutoMapper;
using RestfulChess.Common.Contracts.Figures;

namespace RestfullChess.Api.Mappings
{
    public class FigureMappingProfile : Profile
    {
        public FigureMappingProfile()
        {
            CreateMap<ChessFigure, ChessFigureDto>()
                .Include<Bishop, BishopDto>()
                .Include<King, KingDto>()
                .Include<Knight, KnightDto>()
                .Include<Pawn, PawnDto>()
                .Include<Queen, QueenDto>()
                .Include<Rook, RookDto>()
                .ReverseMap();
            CreateMap<Bishop, BishopDto>().ReverseMap();
            CreateMap<King, KingDto>().ReverseMap();
            CreateMap<Knight, KnightDto>().ReverseMap();
            CreateMap<Pawn, PawnDto>().ReverseMap();
            CreateMap<Queen, QueenDto>().ReverseMap();
            CreateMap<Rook, RookDto>().ReverseMap();
        }
    }
}
