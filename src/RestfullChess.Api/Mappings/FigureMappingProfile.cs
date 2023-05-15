using AutoMapper;
using RestfulChess.Common.Contracts.Figures;

namespace RestfullChess.Api.Mappings
{
    public class FigureMappingProfile : Profile
    {
        public FigureMappingProfile()
        {
            CreateMap<Bishop, BishopDto>().ReverseMap();
            CreateMap<King, KingDto>().ReverseMap();
            CreateMap<Knight, KnightDto>().ReverseMap();
            CreateMap<Pawn, PawnDto>().ReverseMap();
            CreateMap<Queen, QueenDto>().ReverseMap();
            CreateMap<Rook, RookDto>().ReverseMap();
        }
    }
}
