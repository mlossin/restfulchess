using AutoMapper;
using RestfulChess.Common.Contracts.Games;

namespace RestfullChess.Api.Mappings
{
    public class GameMappingProfile : Profile
    {
        public GameMappingProfile()
        {
            CreateMap<BoardField, BoardFieldDto>().ReverseMap();
            CreateMap<ChessBoard, ChessBoardDto>().ReverseMap();
            CreateMap<ChessGame, ChessGameDto>().ReverseMap();
            CreateMap<FigureBox, FigureBoxDto>().ReverseMap();
            CreateMap<PlayerInformation, PlayerInformationDto>().ReverseMap();
        }
    }
}
