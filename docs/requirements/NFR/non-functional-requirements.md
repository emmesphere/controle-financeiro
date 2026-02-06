# Requisitos Não Funcionais

## Escopo
Sistema SaaS para controle financeiro pessoal: contas, transações, categorias, relatórios, projeções e alertas.

---

## NFR-01 – Segurança e Privacidade
- Dados financeiros devem ser criptografados em trânsito (TLS) e em repouso
- Segredos devem ser armazenados em cofre (ex.: Key Vault)
- Acesso a dados deve ser estritamente isolado por usuário (multi-tenant lógico)
- Logs não devem conter dados sensíveis (PII/valores), ou devem ser mascarados

## NFR-02 – Performance
- Operações de consulta principais devem ter latência p95 < 300ms no cenário padrão
- Operações de escrita devem retornar em < 500ms p95 (MVP)

## NFR-03 – Disponibilidade e Resiliência
- Disponibilidade alvo: 99.9% (MVP pode ser best-effort documentado)
- Suportar retries idempotentes em operações assíncronas
- Ter DLQ/poison messages para processamento assíncrono

## NFR-04 – Escalabilidade
- Escalar horizontalmente serviços stateless
- Processamentos pesados (ex.: projeções, relatórios) devem ser assíncronos quando necessário

## NFR-05 – Observabilidade
- Logs estruturados, tracing distribuído (OpenTelemetry) e métricas básicas
- Correlation ID em todas as requisições
- Dashboards mínimos: erros, latência, throughput

## NFR-06 – Manutenibilidade
- Separação clara entre domínio e infraestrutura
- Cobertura mínima de testes em casos críticos (ex.: 60% no MVP, com foco em domínio)
- ADRs para decisões relevantes

## NFR-07 – Conformidade (GDPR/LGPD)
- Exportação de dados do usuário (quando aplicável)
- Exclusão de dados (“direito ao esquecimento”)
- Política de retenção de dados e logs documentada

## NFR-08 – Custos
- Meta de custo: manter o ambiente MVP abaixo de X €/mês
- Telemetria para identificar consumo de recursos
