public class Boss : Mob
{
    public int BossHP { get; set; }
    public int BossAttack { get; set; }
    public Boss(int hp, int attack) : base(hp,attack) 
    {
        BossAttack = attack;
        BossHP = hp;
    }
    public override string ToString()
    {
        return $"Boss with HP = {HP} and attack = {BossAttack}";
    }
}
