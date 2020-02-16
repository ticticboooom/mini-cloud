<template>
  <div id="app">
    <header>
        Mini Cloud Dashboard <a>Services <chevron-down-icon size="20" v-if="!showMenu"></chevron-down-icon></a>
    </header>
    <router-view/>
  </div>
</template>
<script>
import { ChevronDownIcon } from 'vue-feather-icons'
export default {
  data(){
    return {
      showMenu: false
    };
  },
  components:{
      ChevronDownIcon
  }
}
</script>
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

body, html {
  padding: 0;
  margin: 0;
}

header {
  text-align: left;
  padding: 15px 0 0 15px;
  width: 100%;
  height: 50px;
  background-color: #fafafa;
  border-bottom: #dedede solid 1px;
  a {
    padding-left: 20px;
  }
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
  &:hover {
    background-color: #2c3e50;
  }
}

a:hover {
  cursor: pointer;
}
.clearfix::after {
  content: "";
  clear: both;
  display: table;
}
</style>
