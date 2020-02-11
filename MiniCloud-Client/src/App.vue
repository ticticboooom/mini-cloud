<template>
  <div id="app">
    <router-view/>
  </div>
</template>

<style lang="scss">
html {-webkit-text-size-adjust: 100%; -ms-text-size-adjust: 100%;}
* { -moz-box-sizing: border-box; -webkit-box-sizing: border-box; box-sizing: border-box; }

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
.button-primary {
  padding: 5px 15px;
  font-family: upgrade, sans-serif;
  font-size: 1rem;
  background-color:  #2667ff;
  color: #ffffff;
  border: none;
  outline: none;
  border-radius: 5px;
}
</style>
