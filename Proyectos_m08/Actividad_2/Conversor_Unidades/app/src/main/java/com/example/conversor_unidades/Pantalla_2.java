package com.example.conversor_unidades;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.res.Resources;
import android.os.Bundle;
import android.text.Editable;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Switch;
import android.widget.TextView;

public class Pantalla_2 extends AppCompatActivity {
    int[] valores;
    Double valorintroducido;
    private TextView textviewResultado;
    EditText numerointroducido ;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantalla_2);
        Intent intent = getIntent();
        Resources res = getResources();


        String message = intent.getStringExtra(MainActivity.EXTRA_MESSAGE);
        int vista=0;
        // Capture the layout's TextView and set the string as its text
        switch(message){
            case "Datos":
             vista=R.array.ListaUnidades_datos;
               valores = res.getIntArray(R.array.valorunidades_datos);

                break;
        }
        final Spinner origen=findViewById(R.id.spinner_origen);
        final Spinner destino=findViewById(R.id.spinner_destino);
        ArrayAdapter<CharSequence> adapter=ArrayAdapter.createFromResource(this,vista,android.R.layout.simple_spinner_item);
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        origen.setAdapter(adapter);
        destino.setAdapter(adapter);
        Button botonConvertir=findViewById(R.id.bt_convertir);
        botonConvertir.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                numerointroducido =findViewById(R.id.editTextNumberDecimal);
                final Editable textScrito=numerointroducido.getText() ;
                valorintroducido=Double.parseDouble( textScrito.toString());
                textviewResultado=findViewById(R.id.txv_resultado);
               long position=origen.getSelectedItemPosition()-destino.getSelectedItemPosition();
               Double resultado=Calcular(position,valorintroducido);
               textviewResultado.setText(resultado.toString()+" "+destino.getSelectedItem()+"´s");

            }
        });
    }
    public double Calcular(long position,Double dato_introducido){
        double resultado = 0;
        if(position>=0){
            double valor=valores[(int) position];
            resultado=valor*dato_introducido;
        }else{
            position=position*-1;
            double valor=valores[(int) position];
            resultado=dato_introducido/valor;
        }

        return resultado;
    }
}