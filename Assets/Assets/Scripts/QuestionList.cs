using System.Collections.Generic;

[System.Serializable]
public class QuestionList {

	List<Question> questionList = new List<Question>();

	// Use this for initialization

	private void AddQuestionsOne() {
		questionList.Add(new Question(
			"Alex found out Vicky was from West London within the first week of starting UCL",
			true
		));

		questionList.Add(new Question(
			"Vicky used the excuse that he was \"ill\" when Alex beat him in badminton",
			true
		));

		questionList.Add(new Question(
			"Vicky has never complained about TechSoc",
			false
		));

		questionList.Add(new Question(
			"Daniel, Vicky and Alex read the manual & instructions properly before attempting to fly a drone",
			false
		));

		questionList.Add(new Question(
			"Yeechong arrived very late and sat next to Vicky. This is how they met.",
			true
		));

		questionList.Add(new Question(
			"Yeechong slapped Alex in the face with a plate of cake",
			true
		));

		questionList.Add(new Question(
			"\"What is life without risk\" is a line by Daniel Gavrilov during a conversation about planes and drones",
			true
		));

		questionList.Add(new Question(
			"Alex threw up at Paddington Station on one of the last days of first year and was taken home by Vicky and Daniel",
			false
		));

		questionList.Add(new Question(
			"Api was completely fine after chugging trophies of alcohol",
			false
		));

		questionList.Add(new Question(
			"Django sucks.",
			true
		));

		questionList.Add(new Question(
			"Daniel came 1st in the Robotics Race and Alex came 3rd",
			false
		));

		questionList.Add(new Question(
			"#TakeASelfieWithKPSleeping was invented by Vicky",
			true
		));

		questionList.Add(new Question(
			"When we played Basketball, Alex poked Vicky's eye and Daniel kicked the ball into Alex's face",
			true
		));

		questionList.Add(new Question(
			"Daniel likes parks.",
			true
		));

		questionList.Add(new Question(
			"Diana thought that having a higher heart rate was better (e.g. she thought that a heart rate of 80 was better than a heart rate of 60 lol)",
			true
		));

		questionList.Add(new Question(
			"Anita has beaten both Vicky & Alex (while they were playing seriously) in smash bros",
			false
		));

		questionList.Add(new Question(
			"Alex tried out for the Badminton team, whilst hungover from last night",
			true
		));

		questionList.Add(new Question(
			"The game \"Nothing.\" was not brought to UCL by Sri",
			false
		));

		questionList.Add(new Question(
			"Sri & Vicky cook the SPICIEST food anyone has ever eaten in their life",
			true
		));

		questionList.Add(new Question(
			"The first ever \"West London Bonding Session\" happened during rainy weather",
			true
		));
	}

	private void AddQuestionsTwo() {
		questionList.Add(new Question(
			"You are driving 10km/h. It would take you 10 hours to drive 1 km",
			false
		));

		questionList.Add(new Question(
			"Ajia's twin sister's name is Aija",
			false
		));

		questionList.Add(new Question(
			"You put toast in a toaster",
			false
		));

		questionList.Add(new Question(
			"Vika likes to say \"Oh my god.\"",
			true
		));

		questionList.Add(new Question(
			"Alex & Jamie use shots and KFC hot wings to make bets.",
			true
		));

		questionList.Add(new Question(
			"Vicky's favourite colour is blue",
			true
		));

		questionList.Add(new Question(
			"Ajia's favourite colour is not pink",
			false
		));

		questionList.Add(new Question(
			"You are 21 years old. If you were born 5 years ago, you would be 16 years old.",
			false
		));

		questionList.Add(new Question(
			"Hayes Town is a safe place",
			false
		));

		questionList.Add(new Question(
			"Sarcasm is one of Daniel's only talents.",
			true
		));

		questionList.Add(new Question(
			"Axel and Daniel left Alex at the Fabric club and used the excuse \"We thought you left.\"",
			true
		));

		questionList.Add(new Question(
			"Jamie says he is not a player, but he actually is.",
			true
		));

		questionList.Add(new Question(
			"There are 10 birds sitting on a tree, you shoot one down with a rifle, now there are 9 birds left on the tree.",
			false
		));

		questionList.Add(new Question(
			"#TakeASelfieWithKPSleeping was invented by Vicky",
			true
		));

		questionList.Add(new Question(
			"Alex is never late to lectures.",
			false
		));

		questionList.Add(new Question(
			"Yeechong is always late to lectures.",
			true
		));

		questionList.Add(new Question(
			"Alex & Jamie carried Jaz & Galen during Scenario Weeks.",
			true
		));

		questionList.Add(new Question(
			"You have a match. There is a kettle, a fireplace and some firewood. You light the firewood first.",
			false
		));

		questionList.Add(new Question(
			"When you call out Sri's name, you have to say \"Nothing.\"",
			true
		));

		questionList.Add(new Question(
			"During the first year, Greggs was heaven to Vicky.",
			true
		));
	}

	public List<Question> GetQuestionsOne() {
		AddQuestionsOne();
		return questionList;
	}

	public List<Question> GetQuestionsTwo() {
		AddQuestionsTwo();
		return questionList;
	}
}
