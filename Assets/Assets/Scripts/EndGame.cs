using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	public static EndGame instance;

	[SerializeField] private Text scoreText;

	void Awake() {
		if (instance != null) {
			Debug.LogError ("More than one GameManager in scene.");
		} else {
			instance = this;
		}
	}
	
	public void ShowScore(int _score, int _numberOfQuestions) {
		scoreText.text = "<b>" + _score + "/" + _numberOfQuestions + "</b>";
		if (_score < 14) {
			scoreText.text = scoreText.text  + '\n' + "Our friendship is over.";
		} else if (_score < 16) {
			scoreText.text = scoreText.text  + '\n' + "Damn man you are terrible. How do you not remember all the good memories we had?";
		} else if (_score < 18) {
			scoreText.text = scoreText.text  + '\n' + "This is pretty bad man, you only remember a bit of all the good times.";
		} else if (_score < 20) {
			scoreText.text = scoreText.text  + '\n' + "We've known each other for like 2 years and you still can't get 20/20.";
		} else if (_score == (int) (_numberOfQuestions)) {
			scoreText.text = scoreText.text  + '\n' + "Please contact Vicky to claim your reward.";
		}
	}

	public void RetryQuiz() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
