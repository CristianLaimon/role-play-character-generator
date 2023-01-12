using System;

namespace CharacterCreator
{
  public class furrywarrior
  {
    public furrywarrior()
    {
      this.age = randomGenerator.Next(18, 101);
      this.lifePoints = 100;
      this.money = randomGenerator.Next(0, 12);
      this.animalType = animalCatalog[randomGenerator.Next(1, 9)];
      this.especialSkill = especialSkillCatalog[randomGenerator.Next(1, 5)];
      //TODO: Add an empty inventory of 5 spaces for this character
    }

    Random randomGenerator = new Random();
    int age;
    int lifePoints;
    int money;
    string animalType;
    string especialSkill;
    string[] especialSkillCatalog = { "Super Sword", "Dark Twins", "LightGod", "None" };
    string[] animalCatalog = { "Cat", "Fox", "Lion", "Sheep", "Crocodile", "Bear", "Unknown Type" };
    string[] inventory = { "---", "---", "---", "---", "---" };
  }
}