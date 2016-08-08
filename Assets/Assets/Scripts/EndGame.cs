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
		if (_score < _numberOfQuestions * 0.2) {
			scoreText.text = scoreText.text  + '\n' + "You are pretty bad at this.";
		} else if (_score < _numberOfQuestions * 0.4) {
			scoreText.text = scoreText.text  + '\n' + "Not bad, you know some stuff.";
		} else if (_score < _numberOfQuestions * 0.6) {
			scoreText.text = scoreText.text  + '\n' + "Pretty good, you know quite a bit!";
		} else if (_score < _numberOfQuestions * 0.8) {
			scoreText.text = scoreText.text  + '\n' + "Wow! You know so much!";
		} else if (_score == _numberOfQuestions) {
			scoreText.text = scoreText.text  + '\n' + "Please message Jamie to claim your reward of  KFC hotwings.";
		}
	}

	public void RetryQuiz() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
