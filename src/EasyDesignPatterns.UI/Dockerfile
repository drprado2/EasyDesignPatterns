FROM node AS builder
WORKDIR /source
COPY ./src/EasyDesignPatterns.UI .
RUN npm install && npm run build

FROM nginx:alpine
EXPOSE 80
COPY --from=builder /source/build /usr/share/nginx/html
CMD ["nginx", "-g", "daemon off;"]
