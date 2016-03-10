using System;
using System.Collections.Generic;

namespace HAHAHAHA
{
	public class JokesClass
	{
		public List<string> Animal = new List<string>()
		{
			"Q: Why did the cat go to Minnesota?\nA: To get a mini soda!", "Q: What do you call a fish without an eye?\nA: Fsh!",
			"Q: What do you call a cold dog sitting on a bunny?\nA: A chili dog on a bun.", "Q: Where did the sheep go on vacation?\nA: The baaaahamas",
			"Q: How do you make a goldfish old?\nA: Take away the g!"
		}; 
		public List<string> Blonde = new List<string> ()
		{
			"Q: Why are only 2% of blondes touch-typists?\nA: The rest are hunt'n peckers.", "Q: What's the difference between a counterfeit dollar and a skinny blonde?\nA: One's a phony buck.",
			"Q: Whats the difference between a blonde and a mosquito?\n A: When you slap a mosquito it stops sucking.", "Q: Why do blondes wear panties?\n A: To keep their ankles warm.",
			"Q: A blonde ordered a pizza and the clerk asked if he should cut it in six or twelve pieces.\nA: Six, please. I could never eat twelve pieces." 
		}; 
		public List<string> CrossRoad = new List<string> ()
		{
			"Q: Why did George W. Bush cross the road?\nA: To ask his dad how to run the presidency.", "Q; Why did the cow cross the road?\nA: To get to the udder side.",
			"Q:Why didn't the chicken skeleton cross the road?\nA: Because he didn't have enough guts", "Q: Why did the blind blonde cross the road?\nA: She was following her seeing-eye chicken.",
			"Q: Why did the turkey cross the road?\nA: Because he wasn't a chicken."
		}; 
		public List<string> DarkHumor = new List<string> ()
		{
			"Q: What did one casket say to the sick casket?\nA: Is that you coughin?", 
			"A man cheats on his girlfriend Lorraine with a woman named Clearly.\nLorraine dies suddenly.\nAt the funeral, the man stands up and sings, I can see Clearly now, Lorraine is gone.",
			"Q: What goes, Clip clop clip clop clip clop clip clop BANG BANG clip clop clip clop clip clop...\nA: An Amish drive-by shooting.",
			"I think violence is wonderful, but what I object to in boxing is the total lack of explanation as to what happened between these guys to cause this fight to break out. -Andy Blitz",
			"Two men were talking about a friend who had recently passed away.\nBy the time Jack died, he had a transplanted heart, a plastic hip joint, a plastic leg and a plastic arm.\nWhere did they bury him?'\nThey didn't bury him -- he was recycled!"

		};
		public List<string> Fat = new List<string> ()
		{
			"Behind every fat woman there is a beautiful woman. No seriously, your in the way.", "Every time someone calls me fat I get so depress I cut myself... a piece of cake.",
			"I wanted to lose 10 pounds this year. Only 13 to go.", "I found there was only one way to look thin: hang out with fat people.", "I wanted to lose 10 pounds this year. Only 13 to go."
		};
		public List<string> Gross = new List<string> ()
		{
			"I asked my grandma if she had ever tried 69. She said, No, but I have done 53 -- that's all the sailors I could screw in one night.", 
			"Q: What comes after 69?\nA: Mouthwash.", "Q: What do you call a fart?\nA: A turd honking for the right of way.",
			"A man dies, and his wife gets him cremated. She takes the ashes home and starts talking to them.\nYou know that fur coat you promised me? I bought it with the insurance money. You know the new car you promised me? I bought it with the insurance money.\nThen she whispers, You know that blow job I promised you? Well, here it comes.",
			"A blonde goes on a hot date and ends up making out with the guy in his car. The guy asks if she would like to go in the backseat.\nNo! yells the blonde.\nThings get even hotter, and the guy asks again.\nFor the last time, no! says the blonde. Frustrated, the guy asks, Well, why the hell not?\nThe blonde says, Because I wanna stay up here with you!"
		};
		public List<string> Insults = new List<string> ()
		{
			"I'm not saying I hate you, but I would unplug your life support to charge my phone.", "Two wrongs don't make a right, take your parents as an example.",
			"If I wanted to kill myself I'd climb your ego and jump to your IQ.", "Is your ass jealous of the amount of shit that just came out of your mouth?",
			"I'd like to see things from your point of view but I can't seem to get my head that far up my ass."
		}; 
		public List<string> Marriage = new List<string>()
		{
			"A third-grade teacher is getting to know her pupils on the first day of school. She turns to one little girl and says, And what does your daddy do? The girl replies, Whatever Mummy tells him to.",
			"My fiancé and I went to a counselor to work on our communication issues. Using herself as an example, the counselor crossed her legs and her arms and exhaled loudly. I was about to say she was showing signs of frustration, but my fiancé beat me to it, yelling, I’ve got it! You’re constipated!",
			"Marriage is a workshop, where man works and woman shops.", 
			"Q: What's the difference between a girlfriend and a wife?\nA: 45 lbs.\nQ: What's the difference between a boyfriend and a husband?\nA: 45 minutes",
			"Q: What comes with the new Divorced Barbie?\nA: All of Ken's stuff."
		};
		public List<string> PickUp = new List<string>()
		{
			"If I said you had a pronounced sloping brow, would you hold it against me?", "You must be a broom because you just swept me off my feet.", 
			"Your daddy must be a drug dealer, cuz you’re dope.",
			"I didn't know angels could fly so low.", "Baby you be the tree, and I'll wrap around you like a koala bear"
		};
		public List<string> School = new List<string>()
		{
			"Q: Why do they never serve beer at a math party?\n A: Because you can't drink and derive...", "Q: Why wasn't the geometry teacher at school?\nA: Because she sprained her angle!!",
			"Q: What letter of the alphabet has got lots of water?\nA: The C", "Teachers always tell us to follow our dreams....BUT yet they don't let us sleep in class.",
			"Why don't you do arithmetic homework in the jungle? Because if you add 4+4 you get ate."
		};
		public List<string> Tech = new List<string>()
		{
			"What did one computer say to the other?\n010101101010101010101", "Q: What do you get when you cross a gorilla and a computer?\nA: Hairy Reasoner.",
			"After Bill Gates wedding night, his wife finally knew why he called his company Microsoft.", 
			"Q: What did the farmer say when he read that genetic engineers were implanting human DNA into goats?\nA: Hell, I've been doing that for years.", "Why do they call it hyper text? \nToo much JAVA."

		};

		public List<string> Work = new List<string>()
		{
		};
		public List<string> Mama = new List<string>()
		{
		};

		public JokesClass ()
		{
		}

		public string AnimalJoke(int num)
		{
			return Animal [num];
		}

		public string BlondeJoke(int num)
		{
			return Blonde [num];
		}

		public string RoadJoke(int num)
		{
			return CrossRoad [num];
		}

		public string DarkJoke(int num)
		{
			return DarkHumor [num];
		}

		public string FatJoke(int num)
		{
			return Fat [num];
		}

		public string GrossJoke(int num)
		{
			return Gross [num];
		}

		public string InsultsJoke(int num)
		{
			return Insults [num];
		}

		public string MarriageJoke(int num)
		{
			return Marriage [num];
		}

		public string PickUpJoke(int num)
		{
			return PickUp [num];
		}

		public string SchoolJoke(int num)
		{
			return School [num];
		}

		public string TechJoke(int num)
		{
			return Tech [num];
		}
	}
}

