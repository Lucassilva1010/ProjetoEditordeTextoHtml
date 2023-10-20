# Projeto de Edição e Criação de Arquivos HTML no Console

Este é um projeto de edição e criação de arquivos HTML diretamente no console. O projeto tem o intuito de servir como um ambiente de aprendizado para vários conceitos de programação em C#, incluindo lógica, controle de fluxo, entrada e saída, manipulação de strings, classificação de métodos e interação entre classes.

## Funcionalidades

O projeto é composto por várias classes e métodos, cada um com sua responsabilidade específica:

- **Menu Principal (Método de MenuPrincipal)**: Este método lida com a exibição do menu principal no console, permitindo que os usuários interajam com as funcionalidades do projeto. Ele incorpora o aprendizado de entrada e saída.

- **Tela (Método Tela)**: Este método é responsável por chamar outros métodos da classe e é uma excelente oportunidade para treinar a organização do código.

- **Opções de Tela (Método OpcTela)**: Neste método, as opções de menu são estilizadas e o console muda de cor a cada mudança de tela. Isso permite treinar a interação com a interface do usuário.

- **Menu de Opções (Método MenuOpc)**: Neste método, é feita a ligação com os métodos de ações, usando `switch` para controlar o fluxo do programa e treinar a lógica de programação. Além disso, é criada uma saída animada no console, proporcionando uma experiência de aprendizado interativa.

- **Regiões de Classificação (Métodos com #region)**: As regiões de classificação contêm e separam os métodos relacionados à criação do menu de interação, o que auxilia na classificação e organização de métodos, ensinando boas práticas de programação.

### Classe de Editor

- **Tela02 (Método Tela02)**: Este método ensina a manipular a aparência do console e a alterar as cores, proporcionando uma experiência visual interessante.

- **Start (Método Start)**: Este método é uma oportunidade para aprender a criar e manipular arquivos. O uso de `Append`, `StringBuilder` e `Environment.NewLine` auxilia na manipulação de strings e saídas de dados.

- **Salvar (Método Salvar)**: O uso de `StreamWriter` com `using` para salvar arquivos ensina como interagir com o sistema de arquivos. `Thread.Sleep()` ajuda a treinar o controle de atrasos.

### Classe de Viewer

- **Tela03 (Método Tela03)**: Este método ensina a personalizar a aparência do console, criando uma experiência visual única.

- **Replace (Método Replace)**: A manipulação de strings, o uso de expressões regulares (Regex) e métodos de pesquisa e substituição (IndexOf, LastIndexOf, Substring) são oportunidades de aprendizado.

### Classe Open

- **Abertura de Arquivo HTML (Método Abertura)**: O uso de `StreamReader` para abrir arquivos HTML ensina como lidar com a leitura de arquivos.

## Estrutura do Projeto

O projeto é estruturado em classes separadas para ensinar a organização do código e a interação entre classes.

## Como Usar

Para usar o projeto de edição e criação de arquivos HTML no console, siga estas etapas:

1. Clone o repositório para sua máquina local:

   ```bash
   git clone https://github.com/seu-usuario/editor-html-csharp.git
   cd editor-html-csharp
