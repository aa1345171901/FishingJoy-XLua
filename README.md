# FishingJoy-XLua
使用XLua预实现的热更新内容：

version  1.1

1.点击宝箱领取的金币钻石太拥挤，分散一点。
2.玩家金币钻石不够时没有相应处理。

version  1.2

1.与UI交互时不能发射子弹。
2.技能扣钻石太多。
3.boss撞击玩家数值变动一样且不是减少是增加。


version  1.3

1.boss撞击玩家当钻石金币不够时会产生负数。
2.炮台3太强，且钻石没用处，不削弱，只有氪金才可使用。
3.大鱼太多。 

version  1.4

1.扑鱼是考虑了鱼的血量与子弹的伤害来模拟概率，这样玩家体验不好，要使用传统的概率来扑鱼。
2.炮台移动是根据鼠标的水平数值滑动来模拟跟随的，改为玩家按下ad键来旋转炮台。

version  2.0

1.增加新鱼。
2.增加浪潮功能。
3.切换场景。

————————————————————————

Unity使用XLua的注意事项：
      首先开发业务代码->在所有可能出现问题的类上打上hotfix的标签，在所有lua调用CSharp的方法上打上LuaCallCSharp,在所有CSharp调用Lua的方法上打上CSharpCallLua->打包发布->修改bug时只需要更新Lua文件，修改资源时（声音，模型，贴图，图片，UI）只需要更新ab包。用户只需要去下载lua文件跟ab包。
      需要使用CSharp里面原先的代码需要将XLua提供的util.lua导入项目文件夹以及打包发给用户

————————————————————————

开发前做的环境配置：
1.将官网提供的XLua-master文件中的Assets文件里的内容复制到工程的Assets文件夹下
2.把XLua的宏打开，File-Build Settings->Player Settings->other Settings->Scriptsing Define Symbols 输入HOTFIX_ENABLE 按Enter
3.将XLua-master中的Tools文件复制到项目的根目录。
4.将Unity安装目录\Editor\Data\Managed中的Unity.Cecil.Pdb.dll, Unity.Cecil.Mdb.dll , Unity.Cecil.dll 三个文件 放入项目文件\AssetsXLua\Src\Editor\

