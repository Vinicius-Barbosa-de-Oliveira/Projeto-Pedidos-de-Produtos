﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pedidos_de_Produtos
{
    static class NItem
    {
        private static List<Item> Itens = new List<Item>();

        public static void Inserir(Item i)
        {
            Abrir();
            Itens.Add(i);
            Salvar();
        }
        public static List<Item> Listar()
        {
            Abrir();
            return Itens;
        }
        public static Item Listar(int id)
        {
            foreach (Item obj in Itens)
                if (obj.Id == id) return obj;
            return null;
        }
         public static void Atualizar(Item i)
        {
            Abrir();
            Item obj = Listar(i.Id);
            if (obj != null)
            {
                obj.IdPedido = i.IdPedido;
                obj.IdProduto = i.IdProduto;
            }
            Salvar();
        }
        public static void Excluir(Item i)
        {
            Abrir();
            Itens.Remove(Listar(i.Id));
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;

            try
            {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Item>));
                    f = new StreamReader("./Itens.xml");
                    Itens = (List<Item>)xml.Deserialize(f);
            }
            catch
            {
                Itens = new List<Item>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Item>));
            StreamWriter f = new StreamWriter("./Itens.xml", false);
            xml.Serialize(f, Itens);
            f.Close();
        }
        public static void VincularPedido(Item i, Pedido p)
        {
            i.IdPedido = p.Id;
            Atualizar(i);
        }
        public static void VincularProduto(Item i, Produto pro)
        {
            i.IdPedido = pro.Id;
            Atualizar(i);
        }
    }
}
