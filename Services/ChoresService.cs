
using chore_score.Repository;

namespace chore_score.Services;

public class ChoresService
{

  public ChoresService(ChoresRepository choresRepository)
  {
    _choresRepository = choresRepository;
  }
  private readonly ChoresRepository _choresRepository;



  public List<Chore> GetAllChores()
  {
    List<Chore> chores = _choresRepository.GetAllChores();
    return chores;
  }

  public Chore GetChoreById(int choreId)
  {
    Chore chore = _choresRepository.GetChoreById(choreId);
    if (chore == null) throw new Exception($"Invalid chore id {choreId}");
    return chore;
  }
}