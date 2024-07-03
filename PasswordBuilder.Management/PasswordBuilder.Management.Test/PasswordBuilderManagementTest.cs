namespace PasswordBuilder.Management.Test
{
    public class PasswordBuilderManagementTest
    {
        [Fact]
        public void ShouldPasswordBuilder()
        {
            // arrange
            PasswordBuilderManagement management = new();
            // act
            string password = management.PasswordBuilder();
            // assert
            Assert.NotEmpty(password);
        }
    }
}