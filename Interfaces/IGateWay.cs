using GateWayApi.Models;

namespace GateWayApi.Interfaces
{
    public interface IGateWay
    {
        Task<List<Register>> salesReport( int[] year);
        Task<List<Register>> salesReport2( int[] year);
        Task<List<Register3>> salesReport3(int[] year);
        Task<UserModel> auth(LoginCredentials auth);
        Task<List<PersonEmail>> listemail(int id);
    }
}