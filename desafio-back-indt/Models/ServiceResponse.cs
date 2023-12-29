﻿namespace desafio_back_indt.Models
{
    public class ServiceResponse<T>
    {
        public T? Dados { get; set; }

        public string Mensagem { get; set; } = string.Empty;

        public bool Status { get; set; } = true;

    }
}
