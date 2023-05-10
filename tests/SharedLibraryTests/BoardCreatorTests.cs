using RestfulChess.Business.Implementation;
using RestfulChess.Business.Implementation.Validation;

namespace SharedLibraryTests
{
    [TestClass]
    public class BoardCreatorTests
    {
        [TestMethod]
        public void CreateChessBoard_Success()
        {
            //Arrange
            var chessBoard = new ChessBoardCreator().CreateChessBoard();
            var validator = new ChessBoardValidator();
            
            //Act 
            var validationResult = validator.Validate(chessBoard);
            //Assert
            Assert.IsNotNull(chessBoard);
            Assert.AreEqual(64, chessBoard.Fields.Count);
            Assert.IsTrue(validationResult.IsValid);
            Assert.AreEqual(0, validationResult.Errors.Count);


        }
    }
}