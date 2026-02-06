# ADR 0001 – Visão do Sistema

## Status
Aceito

## Contexto
Pessoas têm dificuldade em manter controle consistente de seus gastos, rendimentos, aplicações financeiras.
As soluções mais comuns envolvem o uso de planilhas e requerem tempo, conhecimento técnico e disciplina para a manutenção.

É necessário a criação de uma solução centralizada, acessível e simples, que permita a visualização da saúdi financeira pessoal de forma contínua, sem exigir conhecimento técnico.
## Decisão
Desenvolver uma plataforma SaaS para realizar este controle financeiro pessoal, permitindo o gerenciamento de carteiras, contas, projeções financeiras e visualizações gráficas. 
Com foco em simplicidade, segurança, escalabilidade.

A solução será projetada como um sistema cloud-native, modular, preparado para evoluir com funcionalidades avançadas, como notificações inteligentes e análises automátizadas.

## Alternativas consideradas
- **Soluções prontas de mercado**
Rejeitado por limitar customizações, altos custos e controle sobre dados.

- **Planilhas (Excel/ Google Docs)**
Rejeitado por exigir esforço manual, conhecimento técnico e não oferecer automação, escalabilidade

## Consequências

### Positivas
- Centralização e melhor visualização das infomações.
- Redução do esforço manual para o controle financeiro.
- Arquitetura peparada para evolução incremental.
- Confidencialidade
- Aprendizado

### Negativas
- Necessidade de investimento contínuo em desenvolvimento e manutenção.
- Complexidade sobre segurança e proteção de dados sensíveis.
- Complexidade maior em relação a soluções simples baseadas em planilhas.