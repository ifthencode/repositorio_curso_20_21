package com.example.conversor;

import android.content.Context;
import android.content.res.Resources;
import android.os.Bundle;

import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.text.Editable;
import android.util.Log;
import android.view.View;

import android.view.Menu;
import android.view.MenuItem;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    Context context;

    private TextView textviewResultado;
    private Spinner spinnerConvertir;
    private Spinner spinnerConvertido;
    private EditText recibido;
    int lista;

    @Override
    protected void onCreate(Bundle savedInstanceState) {


        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        Log.d("Demo","**************************************Prueba");
        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });
         textviewResultado=findViewById(R.id.textViewResultado);

        spinnerConvertir=findViewById(R.id.spinnerUnitoConvert);
        spinnerConvertido=findViewById(R.id.spinnerUnitConverted);
        recibido=findViewById(R.id.editTextNumberDecimal);
        final Editable textScrito=recibido.getText() ;
        Button botonCalcular=findViewById(R.id.button);
        botonCalcular.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                //
                Log.d("Demo2", "jkjkjkj" + String.valueOf(recibido.getText().toString().isEmpty()));
                long itemaconvertir = spinnerConvertir.getSelectedItemId();
                long itemconvertido = spinnerConvertido.getSelectedItemId();
                long resultado = 0;
                long recibidonum = 0;
                // int posiciones[] = getResources().getIntArray(R.array.listavaloresDatos);
                long calculo = itemaconvertir - itemconvertido;
                if (recibido.getText().toString().isEmpty()) {

                    Toast toast1 =
                            Toast.makeText(getApplicationContext(),
                                    "Introduce una cantidad a convertir", Toast.LENGTH_SHORT);

                    toast1.show();
                } else {
                    if (itemconvertido == 0) {
                        if (calculo >= 1) {

                            resultado = (long) Math.pow(1024, calculo);
                            recibidonum = Long.parseLong(textScrito.toString());
                            resultado = resultado * recibidonum * 8;

                        }else if (calculo==0){
                            recibidonum = Long.parseLong(textScrito.toString());
                            resultado=recibidonum * 8;
                        }
                        
                    }

                    Log.d("DE", String.valueOf(calculo));
                    textviewResultado.setText(String.valueOf(resultado));
                }
            }
        });

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.

        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {

            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}