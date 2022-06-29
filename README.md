# Unity Mobile Game "Save The Ubeka"
This project developed in 2 week for bachelor thesis

All c# codes located in assests/scripts folder

I develop this game for gain experience in game development which i dont have before

probably file locations is wrong because as i said no experience

i just write c# scripts and use Unity UI, all used assets are ready from unity store.

Project include 5 different levels

![image](https://user-images.githubusercontent.com/78934308/176386343-79be3c0c-6ad2-4d1b-b8f0-8158c0d43589.png)

First is main menu level which only contains start and quit game button

![image](https://user-images.githubusercontent.com/78934308/176386656-ba45e556-81e4-4dd7-946d-2296ace774dc.png)

Later on there is a conversation screen which pass by touching screen

![image](https://user-images.githubusercontent.com/78934308/176386913-f8346b1b-5cbc-4d38-9c48-8ba74e26fb10.png)


This is main screen of level 1
![image](https://user-images.githubusercontent.com/78934308/176386150-8cb78534-0bf9-441f-8edd-14d3b00b49e3.png)

In this screen u can move character by joystick which located bottom-left of screen

There is 3 usable button
J: Jump
A: Attack
S: Shield

Jump and attacks have animations which contains Animation Events which will explain later

Shield button is create blue shield around the character which change state of canTakeDamage variable and has 15 second cooldown which made by using coroutine.
Also shield button have a counter for cooldown right next to it

![image](https://user-images.githubusercontent.com/78934308/176387942-82261d7a-02e2-48f3-aa9e-24f37bf56ec6.png) ![image](https://user-images.githubusercontent.com/78934308/176388120-7dffe6a8-a269-4619-b738-07d7204b2e23.png)

Attack button is starts to play Attack animation which has Animation events that enable and disable attack area

![image](https://user-images.githubusercontent.com/78934308/176388849-e641a37c-d4f6-47f1-a351-3db4cf235576.png) 

Attack area enable at the sword animation and disable right after it

![image](https://user-images.githubusercontent.com/78934308/176389251-8fe56fa0-994a-48d7-a314-54ed0dee0744.png) ![image](https://user-images.githubusercontent.com/78934308/176390818-ddc39b47-5ad5-4cbc-942e-1edad5d2f870.png) 

![attackareaenabledisable](https://user-images.githubusercontent.com/78934308/176394687-d3131675-8c76-4b8a-8052-6d459258a500.gif)



Attack area is contains script which has OnTriggerEnter2D() method that apply Damage to colliding object equal to damage value of object has

![image](https://user-images.githubusercontent.com/78934308/176389649-d14cf464-66d0-4ecb-8954-31514a2d66c8.png)

Damage is a method of Health script which decrease the health variable by parameter of method

Health system is a scripts which contain health variable, damage() method, heal() method, die() method,
If object's health variable below 0 method is Destroy the gameojbect

Heal is usable method for potions which located top-left of screen
![image](https://user-images.githubusercontent.com/78934308/176391377-71cff5d6-bd5d-4886-a1ed-1eb3aeb7e543.png)

There are 2 potion avaiable current state
First red one is health potion which apply heal to the character by using Heal() method of Health script.
The blue one is power potion which increase attack power of character by 2 with using increaseDamage() method of AttackArea script

There 2 way to get these potion.

Fist one is shop, every enemy that killed grants player 5 coin so player can purchase potion through shop

![shopsystem](https://user-images.githubusercontent.com/78934308/176398074-6d201551-92f6-4e40-8aa4-4aca73aad703.gif)

![image](https://user-images.githubusercontent.com/78934308/176392102-f63c3d4c-e280-48dc-a3fd-9ef04dfc5d1b.png)

Other way, there is a drop system which enemies have a chance to drop one of the two potion on death

![image](https://user-images.githubusercontent.com/78934308/176392344-6003971b-1a04-42ec-9a35-6472a7b1d6b6.png)

The enemies has a chance to Duplicate one of the these potion by using Instantiate() Method which allow you duplicate a game object, and move it top of the death location

![dropsystem](https://user-images.githubusercontent.com/78934308/176394179-df02c218-2057-4796-91c7-78704a604179.gif)


The boss of this game is Warlock

![image](https://user-images.githubusercontent.com/78934308/176395735-04d877af-5f04-45d9-97f5-3a9feb5d7f42.png)

Has 2 attack style;
-Fist one is melee attack 

![bossattack](https://user-images.githubusercontent.com/78934308/176396190-c36d4783-d395-4b46-a3bf-af1a7c1214d4.gif)

-Second is a range spell

![bosscast](https://user-images.githubusercontent.com/78934308/176396474-42179589-eb4b-4876-9472-141d063fc723.gif)

Cast spell is create a spell above the player location which increase collider size by the animation
On every second there is a Animation event which increase collider size so it allow the player dodge the spell

![image](https://user-images.githubusercontent.com/78934308/176397010-91339b7c-d942-4f42-8f57-9cac1ac0025f.png)

![spellcolliderincrease](https://user-images.githubusercontent.com/78934308/176397291-a2deaa11-e740-4f3b-bbe8-d33a22cee3b0.gif)

Other enemies is basic just detect the player location and rearrange its own rotation and velocity




