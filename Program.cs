﻿using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>()
{
    new Pessoa(nome: "Hóspede 1"),
    new Pessoa(nome: "Hóspede 2"),
    new Pessoa(nome: "Hóspede 3")
};

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");