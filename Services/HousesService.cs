namespace gregslist_dotnet.Services


public class HousesService
{
  public HousesService(HousesRepository housesRepository)
  {
    _houseRepository = housesRepository;
  private readonly HousesRepository _housesRepository;
}
}
