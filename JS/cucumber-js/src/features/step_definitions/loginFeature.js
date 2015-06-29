
var expect = require('chai').expect;

module.exports = function () {

  this.World = require('../support/world.js').World;

  this.Given(/^I am on the "(.*)" website$/, function (site, callback) {
    this.driver.get(site).then(function () {
      callback();
    });
  });

  this.When(/^I enter "(.*)" into username field$/, function (login, callback) {
    //this.driver.manage().timeouts().implicitlyWait(3000);
    this.waitFor('.login-textedit-login-password');
    this.driver.findElement(this.webdriver.By.id('t-comp8-el'))
      .then(function (element) {
      element.sendKeys(login);
      callback();
    });
  });

  this.When(/^I enter "(.*)" into password field$/, function (password, callback) {
    this.driver.findElement(this.webdriver.By.id('t-comp9-el'))
      .then(function (element) {
      element.sendKeys(password);
      callback();
    });
  });

  this.When(/^I press submit button$/, function (callback) {
    this.driver.findElement(this.webdriver.By.id('t-comp13-textEl'))
      .then(function (element) {
      element.click();
      callback();
    });
  });

  this.Then(/^I should be navigated to master page$/, function (callback) {
    this.waitFor('.main-header-menu-logo-image', 20000);
    this.driver.findElement(this.webdriver.By.id('menuLogoImage-image-view'))
      .then(function (element) {
        expect(element).to.be.visible;
        callback();
    });

  });
};