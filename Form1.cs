using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Se tiene una lista de pacientes de un hospital y se desea realizar un sistema sobre registro de los
//mismos.Los datos de los pacientes son código, nombres, apellido, dirección y teléfono.
//El sistema debe permitir:
//  a. Registrar un nuevo paciente
//  b. Eliminar paciente (en cualquier posición)
//  c. Actualizar Pacientes (modificar algún dato)
//  d. Agregar después del seleccionado.
//  e. Mostrar Listado

namespace ejercicio1TP4
{
    public partial class Form1 : Form
    {
        List list = new List();
        public Form1()
        {
            InitializeComponent();
        }

        public void BtnAddPatient_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0)
            {
                Node newNode = new Node();
                newNode.Code = txtCode.Text;
                newNode.Name = txtName.Text;
                newNode.Surname = txtSurname.Text;
                newNode.Address = txtAddress.Text;
                newNode.Phone = txtPhone.Text;

                listBox1.Items.Add(newNode);
            }
            else
            {
                MessageBox.Show("Error intelectual", "Error humano");
            }

            Resetear();
        }

        private void BtnEditPatient_Click(object sender, EventArgs e)
        {
            Node newNode = new Node();
            newNode.Code = txtCode.Text;
            newNode.Name = txtName.Text;
            newNode.Surname = txtSurname.Text;
            newNode.Address = txtAddress.Text;
            newNode.Phone = txtPhone.Text;

            listBox1.Items.Insert(listBox1.SelectedIndex, newNode);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void BtnDelPatient_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            Resetear();
        }

        private void BtnAddAfterSel_Click(object sender, EventArgs e)
        {
            Node newNode = new Node();
            newNode.Code = txtCode.Text;
            newNode.Name = txtName.Text;
            newNode.Surname = txtSurname.Text;
            newNode.Address = txtAddress.Text;
            newNode.Phone = txtPhone.Text;

            listBox1.Items.Insert(listBox1.SelectedIndex+1, newNode);
            Resetear();
        }

        public void Resetear()
        {
            txtCode.Text = "Codigo";
            txtName.Text = "Nombre";
            txtSurname.Text = "Apellido";
            txtAddress.Text = "Direccion";
            txtPhone.Text = "Telefono";
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }




    public class Node
    {
        public string Code;
        public string Name;
        public string Surname;
        public string Address;
        public string Phone;
        public Node Next;

        public override string ToString()
        {
            return $"{Code} - {Name} - {Surname} - {Address} - {Phone}";
        }
    }
    public class List
    {
        //Nodo Inicial
        public Node Start;

        //agregar al inicio
        public void AddToStart(Node node)
        {
            //verificar si el que se va a agregar es el primero
            if (Start == null)
            {
                Start = node;
            }
            else
            {
                Node auxNode = Start;
                Start = node;
                Start.Next = auxNode;
            }
        }

        //agregar al final
        public void AddToEnd(Node node)
        {
            if (Start == null)
            {
                Start = node;
            }
            else
            {
                Node lastNode = SearchLastNode(Start);
                lastNode.Next = node;
            }
        }
        //buscar el ultimo
        public Node SearchLastNode(Node node)
        {
            if (node.Next == null)
            {
                return node;
            }
            else
            {
                return SearchLastNode(node.Next);
            }
        }
    }

}
    