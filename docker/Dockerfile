# Node.jsのイメージを使用
FROM node:latest

# 作業ディレクトリを設定
WORKDIR /app

# アプリケーションのソースコードをコピー
COPY ./src/ /app/

# 依存関係をインストール
RUN npm install

# アプリケーションを実行
CMD ["npm", "run", "dev"]