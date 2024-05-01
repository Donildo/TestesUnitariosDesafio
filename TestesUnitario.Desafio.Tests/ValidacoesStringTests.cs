using TestesUnitario.Desafio.Console.Services;

namespace TestesUnitario.Desafio.Tests
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes = new ValidacoesString();
        [Fact]
        public void DeveRetonar6QuantidadeCaracteresDaPalavraMatrix()
        {
            //TODO: Corrigir a variavel "texto" e "resultadoEsperado" da seção Arrange

            //Arrange
            var texto = "OlaOla";
            var resultadoEsperado = 6;

            //Act
            var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            //Arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "qualquer";

            //TODO: Corrigir a chamada do metodo "ContemCaractere" da seção Act
            //Act
           var resultado = _validacoes.ContemCaracteres(texto, textoProcurado);

             // Assert
            //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
            Assert.True(resultado);
        }
        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            //Arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "teste";

            //Act
            var resultado = _validacoes.ContemCaracteres(texto,textoProcurado);

            //Assert
            //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
            Assert.False(resultado);
        }

        //TODO: Corrigir a anotação [Fact]
        [Fact]

        public void TextoDeveTerminarComAPalavraProcurado()
        {
            //TODO:Corrigir a variavel "textoProcurado" seção Arrange

            //Arrange
            var texto = "Começo meio e fim do texto procurado";
            var textoProcurado = "procurado";

            //Act
            var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

            //Assert
            Assert.True(resultado);
        }
    }
}