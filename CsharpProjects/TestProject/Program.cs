Random random = new Random();

int hero = 10;
int monster = 10;

while (hero > 0 && monster > 0){

  
  int heroAttack = random.Next(1,11);
  int monsterAttack = random.Next(1,11);

    monster -= heroAttack;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monster} health");

     if (monster <= 0){
    Console.WriteLine("Hero wins");
  }

    hero -= monsterAttack;
    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {hero} health");  

  if (hero <= 0) {
    Console.WriteLine("Monster wins");
  }

}
    
