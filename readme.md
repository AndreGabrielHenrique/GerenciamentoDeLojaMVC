Sequência de eventos que ocorrem para cadastrar um produto.

# Requisição GET: O usuário solicita a página de cadastro de produto.
Controlador: ProdutoController.CadastrarProduto (GET)
View: CadastrarProduto.cshtml é exibida com o formulário.

# Preenchimento e Submissão do Formulário: O usuário preenche o formulário e submete.
Método HTTP: POST
URL: /Produto/CadastrarProduto

# Recepção e Validação dos Dados:
Controlador: ProdutoController.CadastrarProduto (POST)
Validação: O ASP.NET Core valida o modelo Produto.

# Persistência no Banco de Dados:
Ação: O controlador adiciona o produto ao contexto do banco de dados e salva as alterações.

# Redirecionamento:
Ação: Após salvar o produto, o controlador redireciona para a ação Index.