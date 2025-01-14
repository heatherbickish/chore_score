
namespace chore_score.Repository;

public class ChoresRepository
{

  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }
  private readonly IDbConnection _db;



  public List<Chore> GetAllChores()
  {
    string sql = "SELECT * FROM chores;";
    List<Chore> chores = _db.Query<Chore>(sql).ToList();
    return chores;
  }


}