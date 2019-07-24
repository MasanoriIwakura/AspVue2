module.exports = {
  pages: {
    index: {
      entry: 'src/main.js',
      template: 'public/index.html',
      filename: 'index.html',
      title: 'AspVue2'
    }
  },
  outputDir: '../docker/nginx/dist'
}