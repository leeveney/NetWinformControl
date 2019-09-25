// ***********************************************************************
// Assembly         : HZH_Controls
// Created          : 2019-09-17
//
// ***********************************************************************
// <copyright file="SeriesCollectionEditor.cs">
//     Copyright by Huang Zhenghui(������) All, QQ group:568015492 QQ:623128629 Email:623128629@qq.com
// </copyright>
//
// Blog: https://www.cnblogs.com/bfyx
// GitHub��https://github.com/kwwwvagaa/NetWinformControl
// gitee��https://gitee.com/kwwwvagaa/net_winform_custom_control.git
//
// If you use this code, please keep this note.
// ***********************************************************************

using System;
using System.ComponentModel.Design;

namespace HZH_Controls.Controls
{
    /// <summary>
    /// Class SeriesCollectionEditor.
    /// Implements the <see cref="System.ComponentModel.Design.CollectionEditor" />
    /// </summary>
    /// <seealso cref="System.ComponentModel.Design.CollectionEditor" />
	public class SeriesCollectionEditor : CollectionEditor
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesCollectionEditor"/> class.
        /// </summary>
        /// <param name="type">�˱༭��Ҫ�༭�ļ��ϵ����͡�</param>
		public SeriesCollectionEditor(Type type)
			: base(type)
		{
		}

        /// <summary>
        /// ָʾ�Ƿ��һ��ѡ���������
        /// </summary>
        /// <returns>�������ͬʱѡ�������ϳ�Ա����Ϊ true������Ϊ false��Ĭ������£��������� true��</returns>
		protected override bool CanSelectMultipleInstances()
		{
			return true;
		}

        /// <summary>
        /// ��ȡ�˼��ϱ༭���ɰ������������͡�
        /// </summary>
        /// <returns>�˼��Ͽɰ����������������顣</returns>
		protected override Type[] CreateNewItemTypes()
		{
			return new Type[6]
			{
				typeof(BezierSeries),
				typeof(ColumnSeries),
				typeof(LabelSeries),
				typeof(LineSeries),
				typeof(PointSeries),
				typeof(StandardLineSeries)
			};
		}

        /// <summary>
        /// ����ָ���ļ��������͵���ʵ����
        /// </summary>
        /// <param name="itemType">Ҫ�����������͡�</param>
        /// <returns>ָ���������ʵ����</returns>
		protected override object CreateInstance(Type itemType)
		{
			if (itemType == typeof(BezierSeries))
			{
				return new BezierSeries();
			}
			if (itemType == typeof(ColumnSeries))
			{
				return new ColumnSeries();
			}
			if (itemType == typeof(LabelSeries))
			{
				return new LabelSeries();
			}
			if (itemType == typeof(LineSeries))
			{
				return new LineSeries();
			}
			if (itemType == typeof(PointSeries))
			{
				return new PointSeries();
			}
			if (itemType == typeof(StandardLineSeries))
			{
				return new StandardLineSeries();
			}
			return null;
		}
	}
}
