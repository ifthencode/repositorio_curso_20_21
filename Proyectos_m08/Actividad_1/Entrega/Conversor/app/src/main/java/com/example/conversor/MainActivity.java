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

import java.math.BigDecimal;
import java.math.BigInteger;
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

                long itemaconvertir = spinnerConvertir.getSelectedItemId();
                long itemconvertido = spinnerConvertido.getSelectedItemId();
                //BigInteger bigrecibido;
              // BigInteger bigresultado = null;
                BigDecimal bigDecimalResultado = null;
                BigDecimal bigDecimalRecibido;
                // int posiciones[] = getResources().getIntArray(R.array.listavaloresDatos);
                long calculo = itemaconvertir - itemconvertido;
                if (recibido.getText().toString().isEmpty()) {

                    Toast toast1 =
                            Toast.makeText(getApplicationContext(),
                                    "Introduce una cantidad a convertir", Toast.LENGTH_SHORT);

                    toast1.show();
                } else {
                    if (itemconvertido == 0|itemaconvertir==0) {
                        if (calculo > 0) {

                            bigDecimalResultado =BigDecimal.valueOf( (long) Math.pow(1000, calculo-1));
                            bigDecimalRecibido =BigDecimal.valueOf( Long.parseLong(textScrito.toString()));
                            bigDecimalResultado = bigDecimalResultado.multiply( bigDecimalRecibido.multiply(BigDecimal.valueOf(8)));

                        }else if (calculo==0){
                            bigDecimalRecibido =BigDecimal.valueOf( Long.parseLong(textScrito.toString()));
                            bigDecimalResultado=bigDecimalRecibido.multiply(BigDecimal.valueOf(1));
                        }else if (calculo < 0) {

                                bigDecimalResultado =BigDecimal.valueOf( (long) Math.pow(1000, ((calculo*(-1)-1))));
                                bigDecimalRecibido =BigDecimal.valueOf( Long.parseLong(textScrito.toString()));
                                bigDecimalResultado = bigDecimalRecibido.divide(BigDecimal.valueOf(8).multiply(bigDecimalResultado));






                        }
                        
                    }else if(itemconvertido >0 ){
                        if (calculo > 0) {

                            bigDecimalResultado =BigDecimal.valueOf( (long) Math.pow(1024, calculo));
                            bigDecimalRecibido =BigDecimal.valueOf( Long.parseLong(textScrito.toString()));
                            bigDecimalResultado = bigDecimalResultado.multiply( bigDecimalRecibido);

                        }else if (calculo==0){
                            bigDecimalRecibido =BigDecimal.valueOf( Long.parseLong(textScrito.toString()));
                            bigDecimalResultado=bigDecimalRecibido.multiply(BigDecimal.valueOf(1));
                        } else if (calculo < 0) {

                            bigDecimalResultado =BigDecimal.valueOf( (long) Math.pow(1024, (calculo*(-1))));
                            bigDecimalRecibido =BigDecimal.valueOf( Long.parseLong(textScrito.toString()));
                            bigDecimalResultado =  bigDecimalRecibido.divide(bigDecimalResultado);

                        }


                    }

                    Log.d("Escribir resultado", bigDecimalResultado.toString());
                    textviewResultado.setText(bigDecimalResultado.toString());
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