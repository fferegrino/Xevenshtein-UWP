package org.fferegrino.android.xevenshtein;

import android.app.Activity;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.*;

import org.fferegrino.android.xevenshtein.core.Levenshtein;


public class MainActivity extends ActionBarActivity {

    private Button computeButton;
    private EditText firstWordTextInput, secondWordTextInput;
    private TextView resultTextView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_main);

        computeButton = (Button) findViewById(R.id.ComputeButton);
        firstWordTextInput = (EditText) findViewById(R.id.FirstWordTextInput);
        secondWordTextInput = (EditText) findViewById(R.id.SecondWordTextInput);
        resultTextView = (TextView) findViewById(R.id.ResultTextView);

        computeButton.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                String result = new  Integer(Levenshtein.Compute(firstWordTextInput.getText().toString(), secondWordTextInput.getText().toString())).toString();
                resultTextView.setText(result.toCharArray(),0, result.length());
            }
        });
    }
}
