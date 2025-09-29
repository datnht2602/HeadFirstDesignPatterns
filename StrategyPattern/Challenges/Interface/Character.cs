namespace StrategyPattern.Challenges.Interface;

public abstract class Character
{
    private IWeaponBehavior _weaponBehavior;

    public abstract void Fight();

    public void SetWeapon(IWeaponBehavior weaponBehavior)
    {
        _weaponBehavior = weaponBehavior;
    }
}