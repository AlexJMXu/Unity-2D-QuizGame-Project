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
			scoreText.text = scoreText.text  + '\n' + "You are terrible.";
		} else if (_score < 16) {
			scoreText.text = scoreText.text  + '\n' + "You are bad.";
		} else if (_score < 18) {
			scoreText.text = scoreText.text  + '\n' + "Getting there but still pretty bad";
		} else if (_score < 20) {
			scoreText.text = scoreText.text  + '\n' + "Hahahaha so close yet so far.";
		} else if (_score == (int) (_numberOfQuestions)) {
			scoreText.text = scoreText.text  + '\n' + "Please contact Vicky to claim your reward.";
		}
	}

	public void RetryQuiz() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
