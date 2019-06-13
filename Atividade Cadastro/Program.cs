/*
 * Created by SharpDevelop.
 * User: ADM
 * Date: 10/06/2019
 * Time: 19:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Atividade_Cadastro
{

    public static class Program 
    {
        public static void Main() 
        {
            string cliente;
			float saldo;
			
			void CadastrarUsuario()
		  	  
			{
			  	Console.WriteLine("Seja Bem Vindo, Primeiro Informe seu nome:");
			  	cliente= Console.ReadLine();
			  	
			  	Console.WriteLine("Agora Informe o saldo do Usuário:");
			  	saldo = float.Parse(Console.ReadLine());
			  	
		    }
			  
			void ConsultarConta()
			{
			  	Console.WriteLine("A conta de " + cliente + " Contém " + saldo + " de saldo.");
			  	
			}
			
			void ApagarConta()
			{
			  	cliente = string.Empty;
			  	saldo = 0;
			  	Console.WriteLine ("Conta apagada com sucesso!!");
			  	
	
			}
			
			CadastrarUsuario ();
			ConsultarConta();
			ApagarConta ();
           
        }
    }
}