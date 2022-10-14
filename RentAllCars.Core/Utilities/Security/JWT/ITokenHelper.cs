using RentAllCars.Core.Entities.Concrete;


namespace RentAllCars.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
