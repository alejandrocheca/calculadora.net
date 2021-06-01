
namespace CalculadoraMicrosoft
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtpantalla = new System.Windows.Forms.TextBox();
            this.porcentaje = new System.Windows.Forms.Button();
            this.boenre = new System.Windows.Forms.Button();
            this.boulca = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.fracciones = new System.Windows.Forms.Button();
            this.elevcuadrado = new System.Windows.Forms.Button();
            this.raizcuadrado = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.sumar = new System.Windows.Forms.Button();
            this.cambiosigno = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.coma = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpantalla
            // 
            this.txtpantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtpantalla.Location = new System.Drawing.Point(10, 14);
            this.txtpantalla.Margin = new System.Windows.Forms.Padding(5);
            this.txtpantalla.Multiline = true;
            this.txtpantalla.Name = "txtpantalla";
            this.txtpantalla.ReadOnly = true;
            this.txtpantalla.Size = new System.Drawing.Size(266, 71);
            this.txtpantalla.TabIndex = 0;
            this.txtpantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // porcentaje
            // 
            this.porcentaje.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.porcentaje.Location = new System.Drawing.Point(8, 91);
            this.porcentaje.Margin = new System.Windows.Forms.Padding(5);
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(60, 50);
            this.porcentaje.TabIndex = 1;
            this.porcentaje.Text = "%";
            this.porcentaje.UseVisualStyleBackColor = true;
            this.porcentaje.Click += new System.EventHandler(this.porcentaje_Click);
            // 
            // boenre
            // 
            this.boenre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boenre.Location = new System.Drawing.Point(74, 91);
            this.boenre.Margin = new System.Windows.Forms.Padding(5);
            this.boenre.Name = "boenre";
            this.boenre.Size = new System.Drawing.Size(62, 50);
            this.boenre.TabIndex = 2;
            this.boenre.Text = "CE";
            this.boenre.UseVisualStyleBackColor = true;
            this.boenre.Click += new System.EventHandler(this.boenre_Click);
            // 
            // boulca
            // 
            this.boulca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boulca.Location = new System.Drawing.Point(142, 91);
            this.boulca.Margin = new System.Windows.Forms.Padding(5);
            this.boulca.Name = "boulca";
            this.boulca.Size = new System.Drawing.Size(59, 50);
            this.boulca.TabIndex = 3;
            this.boulca.Text = "C";
            this.boulca.UseVisualStyleBackColor = true;
            this.boulca.Click += new System.EventHandler(this.boulca_Click);
            // 
            // borrar
            // 
            this.borrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.borrar.Location = new System.Drawing.Point(207, 91);
            this.borrar.Margin = new System.Windows.Forms.Padding(5);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(67, 50);
            this.borrar.TabIndex = 4;
            this.borrar.Text = "<x|";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // fracciones
            // 
            this.fracciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fracciones.Location = new System.Drawing.Point(8, 147);
            this.fracciones.Margin = new System.Windows.Forms.Padding(5);
            this.fracciones.Name = "fracciones";
            this.fracciones.Size = new System.Drawing.Size(60, 48);
            this.fracciones.TabIndex = 5;
            this.fracciones.Text = "1/x";
            this.fracciones.UseVisualStyleBackColor = true;
            this.fracciones.Click += new System.EventHandler(this.fracciones_Click);
            // 
            // elevcuadrado
            // 
            this.elevcuadrado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elevcuadrado.Location = new System.Drawing.Point(74, 147);
            this.elevcuadrado.Margin = new System.Windows.Forms.Padding(5);
            this.elevcuadrado.Name = "elevcuadrado";
            this.elevcuadrado.Size = new System.Drawing.Size(62, 50);
            this.elevcuadrado.TabIndex = 6;
            this.elevcuadrado.Text = "x²";
            this.elevcuadrado.UseVisualStyleBackColor = true;
            this.elevcuadrado.Click += new System.EventHandler(this.elevcuadrado_Click);
            // 
            // raizcuadrado
            // 
            this.raizcuadrado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.raizcuadrado.Location = new System.Drawing.Point(142, 147);
            this.raizcuadrado.Margin = new System.Windows.Forms.Padding(5);
            this.raizcuadrado.Name = "raizcuadrado";
            this.raizcuadrado.Size = new System.Drawing.Size(59, 50);
            this.raizcuadrado.TabIndex = 7;
            this.raizcuadrado.Text = "√x";
            this.raizcuadrado.UseVisualStyleBackColor = true;
            this.raizcuadrado.Click += new System.EventHandler(this.raizcuadrado_Click);
            // 
            // dividir
            // 
            this.dividir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dividir.Location = new System.Drawing.Point(207, 147);
            this.dividir.Margin = new System.Windows.Forms.Padding(5);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(67, 50);
            this.dividir.TabIndex = 8;
            this.dividir.Text = "÷";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // siete
            // 
            this.siete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.siete.Location = new System.Drawing.Point(10, 201);
            this.siete.Margin = new System.Windows.Forms.Padding(5);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(59, 49);
            this.siete.TabIndex = 9;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = true;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // ocho
            // 
            this.ocho.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ocho.Location = new System.Drawing.Point(75, 201);
            this.ocho.Margin = new System.Windows.Forms.Padding(5);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(62, 49);
            this.ocho.TabIndex = 10;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // nueve
            // 
            this.nueve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nueve.Location = new System.Drawing.Point(143, 202);
            this.nueve.Margin = new System.Windows.Forms.Padding(5);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(59, 48);
            this.nueve.TabIndex = 11;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multiplicar.Location = new System.Drawing.Point(208, 201);
            this.multiplicar.Margin = new System.Windows.Forms.Padding(5);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(67, 49);
            this.multiplicar.TabIndex = 12;
            this.multiplicar.Text = "x";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // cuatro
            // 
            this.cuatro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cuatro.Location = new System.Drawing.Point(9, 256);
            this.cuatro.Margin = new System.Windows.Forms.Padding(5);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(59, 50);
            this.cuatro.TabIndex = 13;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // cinco
            // 
            this.cinco.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cinco.Location = new System.Drawing.Point(75, 256);
            this.cinco.Margin = new System.Windows.Forms.Padding(5);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(62, 50);
            this.cinco.TabIndex = 14;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // seis
            // 
            this.seis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seis.Location = new System.Drawing.Point(143, 256);
            this.seis.Margin = new System.Windows.Forms.Padding(5);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(59, 50);
            this.seis.TabIndex = 15;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // restar
            // 
            this.restar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.restar.Location = new System.Drawing.Point(208, 256);
            this.restar.Margin = new System.Windows.Forms.Padding(5);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(67, 50);
            this.restar.TabIndex = 16;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // uno
            // 
            this.uno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uno.Location = new System.Drawing.Point(10, 312);
            this.uno.Margin = new System.Windows.Forms.Padding(5);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(59, 50);
            this.uno.TabIndex = 17;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // dos
            // 
            this.dos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dos.Location = new System.Drawing.Point(75, 312);
            this.dos.Margin = new System.Windows.Forms.Padding(5);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(62, 50);
            this.dos.TabIndex = 18;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // tres
            // 
            this.tres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tres.Location = new System.Drawing.Point(143, 312);
            this.tres.Margin = new System.Windows.Forms.Padding(5);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(59, 50);
            this.tres.TabIndex = 19;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // sumar
            // 
            this.sumar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sumar.Location = new System.Drawing.Point(208, 312);
            this.sumar.Margin = new System.Windows.Forms.Padding(5);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(67, 50);
            this.sumar.TabIndex = 20;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // cambiosigno
            // 
            this.cambiosigno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cambiosigno.Location = new System.Drawing.Point(11, 368);
            this.cambiosigno.Margin = new System.Windows.Forms.Padding(5);
            this.cambiosigno.Name = "cambiosigno";
            this.cambiosigno.Size = new System.Drawing.Size(59, 50);
            this.cambiosigno.TabIndex = 21;
            this.cambiosigno.Text = "+/-";
            this.cambiosigno.UseVisualStyleBackColor = true;
            this.cambiosigno.Click += new System.EventHandler(this.cambiosigno_Click);
            // 
            // cero
            // 
            this.cero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cero.Location = new System.Drawing.Point(76, 368);
            this.cero.Margin = new System.Windows.Forms.Padding(5);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(62, 50);
            this.cero.TabIndex = 22;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // coma
            // 
            this.coma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.coma.Location = new System.Drawing.Point(144, 368);
            this.coma.Margin = new System.Windows.Forms.Padding(5);
            this.coma.Name = "coma";
            this.coma.Size = new System.Drawing.Size(59, 50);
            this.coma.TabIndex = 23;
            this.coma.Text = ",";
            this.coma.UseVisualStyleBackColor = true;
            this.coma.Click += new System.EventHandler(this.coma_Click);
            // 
            // igual
            // 
            this.igual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.igual.Location = new System.Drawing.Point(209, 368);
            this.igual.Margin = new System.Windows.Forms.Padding(5);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(67, 50);
            this.igual.TabIndex = 24;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(290, 419);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.coma);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.cambiosigno);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.raizcuadrado);
            this.Controls.Add(this.elevcuadrado);
            this.Controls.Add(this.fracciones);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.boulca);
            this.Controls.Add(this.boenre);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.txtpantalla);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpantalla;
        private System.Windows.Forms.Button porcentaje;
        private System.Windows.Forms.Button boenre;
        private System.Windows.Forms.Button boulca;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button fracciones;
        private System.Windows.Forms.Button elevcuadrado;
        private System.Windows.Forms.Button raizcuadrado;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button cambiosigno;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button coma;
        private System.Windows.Forms.Button igual;
    }
}

