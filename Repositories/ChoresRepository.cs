


using System.ComponentModel.Design;

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

  public Chore GetChoreById(int choreId)
  {
    string sql = "SELECT * FROM chores WHERE id = @choreId;";
    Chore chore = _db.Query<Chore>(sql, new { choreId = choreId }).SingleOrDefault();
    return chore;
  }

  public Chore CreateChore(Chore choreData)
  {
    string sql = @"
    INSERT INTO 
    chores(name, description, isComplete)
    VALUES(@Name, @Description, @IsComplete);

    SELECT * FROM chores WHERE id = LAST_INSERT_ID()";
    Chore chore = _db.Query<Chore>(sql, choreData).SingleOrDefault();
    return chore;
  }

  public void DeleteChore(int choreId)
  {
    string sql = "DELETE FROM chores WHERE id = @choreId LIMIT 1;";
    int rowsAffected = _db.Execute(sql, new { choreId });

    if (rowsAffected == 0) throw new Exception("No rows were deleted!");
    if (rowsAffected > 1) throw new Exception($"{rowsAffected} rows were deleted!");
  }


}