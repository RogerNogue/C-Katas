namespace RPGCombat;

public class Affiliations
{
    HashSet<string> affiliations = new HashSet<string>();

    public void Join(string faction)
    {
        affiliations.Add(faction);
    }

    public void Leave(string faction)
    {
        affiliations.Remove(faction);
    }

    public bool BelongsTo(string faction)
    {
        return affiliations.Contains(faction);
    }
    
    public bool BelongsToAny()
    {
        return affiliations.Count > 0;
    }
}