package com.example.getlatitudelongitude;

import androidx.appcompat.app.AppCompatActivity;

import android.location.Address;
import android.location.Geocoder;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import java.io.IOException;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    private EditText editText;
    private TextView textView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        editText = findViewById(R.id.editTextTextPersonName);
        textView = findViewById(R.id.textView);

    }

    public void buttonGetLocation (View view){

        Geocoder geocoder = new Geocoder(this);
        List<Address> addressList;

        try {
            addressList = geocoder.getFromLocationName(editText.getText().toString(), 1);

            if (addressList != null){
                double doubleLat = addressList.get(0).getLatitude();
                double doubleLong = addressList.get(0).getLongitude();

                textView.setText("Latitude: " +  String.valueOf(doubleLat)
                + " | " + "Longitude: " + String.valueOf(doubleLong));
            }

        } catch (IOException e) {
            e.printStackTrace();
        }

    }
}