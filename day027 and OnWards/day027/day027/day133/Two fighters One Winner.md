<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #133: 

* <b>Difficulty:</b> 7 kyu
* <b>Solution Class:</b> [Two Fighers, One Winner](DeclareWinner.cs)
* <b>Solved:</b> Friday, June 15<sup>th</sup>, 2018

Details:

Create a function that returns the name of the winner in a fight between two fighters.

Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.

Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.

Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.

Example:
public class Fighter {
  public string Name;
  public int Health, DamagePerAttack;
  public Fighter(string name, int health, int damagePerAttack) {
    this.Name = name;
    this.Health = health;
    this.DamagePerAttack = damagePerAttack;
  }
}
