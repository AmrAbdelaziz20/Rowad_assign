namespace libarysystem;

public class MemberMangement
{
    private List<member> members_list = new List<member>();
    public void registring (member member){
        members_list.Add(member);
    }
    public void display_members(){
        foreach (var member in members_list)
        {
            Console.WriteLine(member);
        }
    }
}
